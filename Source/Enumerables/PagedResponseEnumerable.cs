using System;
using System.Collections;
using System.Collections.Generic;
using YoutubeSnoop.Entities;

namespace YoutubeSnoop.Enumerables
{
    public class PagedResponseEnumerable<TItem> : IEnumerable<Response<TItem>>
        where TItem : Interfaces.IResponse
    {
        private Response<TItem> _response;
        private Func<string, Response<TItem>> _getNextResponse;

        public PagedResponseEnumerable(Response<TItem> firstResponse, Func<string, Response<TItem>> getNextResponse)
        {
            _response = firstResponse;
            _getNextResponse = getNextResponse;
        }

        public IEnumerator<Response<TItem>> GetEnumerator()
        {
            return new PagedResponseEnumerator<TItem>(_response, _getNextResponse);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}