﻿namespace Entities.RequestFeatures;

public abstract class RequestParameters
    {
		const int maxPageSize = 50;

		public int PageNumber { get; set; } = 1;
		
		
		private int _pageSize = 50;

		public int PageSize
		{
			get { return _pageSize; }
			set
			{
				_pageSize = value > maxPageSize || value <= 0 ? maxPageSize : value;
			}
		}

		public string? Fields { get; set; }
		public string? SearchTerm { get; set; }

	}