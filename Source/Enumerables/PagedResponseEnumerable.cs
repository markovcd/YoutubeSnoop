using System;
using System.Collections;
using System.Collections.Generic;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Enumerables
{
    public class PagedResponseEnumerable<TItem> : IEnumerable<Response<TItem>>
        where TItem : IResponse
    {
        private readonly Func<string, Response<TItem>> _getNextResponse;

        public PagedResponseEnumerable(Func<string, Response<TItem>> getNextResponse)
        {
            _getNextResponse = getNextResponse;
        }

        public IEnumerator<Response<TItem>> GetEnumerator()
        {
            return new PagedResponseEnumerator<TItem>(_getNextResponse);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}