using System;
using System.Collections;
using System.Collections.Generic;
using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop.Api
{
    /// <summary>
    /// Enumerator for paged results of Youtube API response. Don't use directly - it is used by ApiRequest internally.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public class PagedResponseEnumerator<TItem> : IEnumerator<IPagedResponse<TItem>>
        where TItem : IResponse
    {
        private readonly IList<IPagedResponse<TItem>> _responses;
        private int _index;
        private readonly Func<string, IPagedResponse<TItem>> _getNextResponse;

        public IPagedResponse<TItem> Current => _responses[_index];
        object IEnumerator.Current => Current;

        public PagedResponseEnumerator(Func<string, IPagedResponse<TItem>> getNextResponse)
        {
            _index = -1;
            _responses = new List<IPagedResponse<TItem>>();
            _getNextResponse = getNextResponse;
        }

        public bool MoveNext()
        {
            _index++;

            if (_responses.Count == 0)
            {
                _responses.Add(_getNextResponse(null));
            }
            else if (_index == _responses.Count)
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

        public void Dispose()
        {
        }
    }
}