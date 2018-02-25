using System;
using System.Collections;
using System.Collections.Generic;

namespace YoutubeSnoop.Entities.Enumerables
{
    public class PagedResponseEnumerable<TResponse, TItem> : IEnumerable<TResponse>
        where TResponse : Interfaces.IPagedResponse<TItem>
        where TItem : Interfaces.ISnippetResponse
    {
        private TResponse _response;
        private Func<string, TResponse> _getNextResponse;

        public PagedResponseEnumerable(TResponse firstResponse, Func<string, TResponse> getNextResponse)
        {
            _response = firstResponse;
            _getNextResponse = getNextResponse;
        }

        public IEnumerator<TResponse> GetEnumerator()
        {
            return new PagedResponseEnumerator<TResponse, TItem>(_response, _getNextResponse);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    
}
