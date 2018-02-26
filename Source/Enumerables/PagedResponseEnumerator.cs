using System;
using System.Collections;
using System.Collections.Generic;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Enumerables
{
    public class PagedResponseEnumerator<TItem> : IEnumerator<Response<TItem>>
        where TItem : IResponse
    {
        private readonly IList<Response<TItem>> _responses;
        private int _index;
        private Func<string, Response<TItem>> _getNextResponse;

        public Response<TItem> Current => _responses[_index];
        object IEnumerator.Current => Current;

        public PagedResponseEnumerator(Response<TItem> firstResponse, Func<string, Response<TItem>> getNextResponse)
        {
            _index = -1;
            _responses = new List<Response<TItem>> { firstResponse };
            _getNextResponse = getNextResponse;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _index++;

            if (_index == _responses.Count)
            {
                if (string.IsNullOrWhiteSpace(_responses[_index - 1].NextPageToken)) return false;
                _responses.Add(_getNextResponse(_responses[_index - 1].NextPageToken));
            }

            return true;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}