﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackService.Api.DTOs
{
    public class CreateTrackDTO
    {
        public int ProfileId { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
    }
}
