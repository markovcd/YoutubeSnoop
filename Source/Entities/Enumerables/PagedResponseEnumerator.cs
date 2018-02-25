using System;
using System.Collections;
using System.Collections.Generic;

namespace YoutubeSnoop.Entities.Enumerables
{
    public class PagedResponseEnumerator<TResponse, TItem> : IEnumerator<TResponse>
        where TResponse : Interfaces.IPagedResponse<TItem>
        where TItem : Interfaces.ISnippetResponse
    {
        private readonly IList<TResponse> _responses;
        private int _index;
        private Func<string, TResponse> _getNextResponse;

        public TResponse Current => _responses[_index];
        object IEnumerator.Current => Current;

        public PagedResponseEnumerator(TResponse firstResponse, Func<string, TResponse> getNextResponse)
        {
            _index = -1;
            _responses = new List<TResponse> { firstResponse };
            _getNextResponse = getNextResponse;
        }

        public void Dispose() { }

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
