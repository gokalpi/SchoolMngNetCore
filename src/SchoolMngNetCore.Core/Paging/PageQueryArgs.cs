using System.Collections.Generic;

namespace SchoolMngNetCore.Core.Paging
{
    public class PageQueryArgs
    {
        /// <summary>
        /// Page index
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// Page size
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Sorting options
        /// </summary>
        public List<SortingOption> SortingOptions { get; set; }

        /// <summary>
        /// Filtering options
        /// </summary>
        public List<FilteringOption> FilteringOptions { get; set; }
    }
}