/*
	Copyright (c) 2012 Code Owls LLC

	Permission is hereby granted, free of charge, to any person obtaining a copy 
	of this software and associated documentation files (the "Software"), to 
	deal in the Software without restriction, including without limitation the 
	rights to use, copy, modify, merge, publish, distribute, sublicense, and/or 
	sell copies of the Software, and to permit persons to whom the Software is 
	furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in 
	all copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
	FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
	IN THE SOFTWARE. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Mono.Data.PowerShell.Provider;
using Mono.Data.PowerShell.Provider.PathNodeProcessors;
using Mono.Data.PowerShell.Provider.PathNodes;

namespace Mono.Data.OData.Provider
{
    public class ODataRootNodeFactory : ODataNodeFactoryBase
    {
        private readonly Uri _uri;
        private readonly XDocument _document;
        private readonly XDocument _metadata;

        public ODataRootNodeFactory(Uri uri, XDocument document, XDocument metadata) : base( uri, metadata, document.Root, "Feed" )
        {
            _uri = uri;
            _document = document;
            _metadata = metadata;
        }

        public override IEnumerable<INodeFactory> Resolve(IContext context, string nodeName)
        {
            var elements = from collection in _document.Descendants(Names.Collection)
                           let href = collection.Attribute(Names.HrefAttribute)
                           where null != href && StringComparer.InvariantCultureIgnoreCase.Equals(href.Value, nodeName)
                           select (INodeFactory)new ODataCollectionNodeFactory( new Uri( BaseUri, href.Value ), _metadata, collection );

            return elements.ToList();
        }


        public override IEnumerable<INodeFactory> GetNodeChildren(IContext context)
        {
            var elements = from t in _document.Descendants(Names.Collection)
                           let href = t.Attribute(Names.HrefAttribute)
                           select
                               (INodeFactory) new ODataCollectionNodeFactory(new Uri(BaseUri, href.Value), _metadata, t);
            return elements.ToList();
        }

        public override IPathNode GetNodeValue()
        {
            return new PathNode(_document, Name, true);
        }

        public override string Name
        {
            get
            {
                return (from t in _document.Descendants(Names.Title)
                        where t.Parent.Name.LocalName == "workspace"
                        select t).First().Value;
            }
        }
    }
}
