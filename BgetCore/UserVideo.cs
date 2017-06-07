﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BgetCore
{
    public class VideoList
    {
        [JsonProperty("comment")]
        public int Comment { get; set; }

        [JsonProperty("typeid")]
        public int Typeid { get; set; }

        [JsonProperty("play")]
        public int Play { get; set; }

        [JsonProperty("pic")]
        public string Pic { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("review")]
        public int Review { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("mid")]
        public int Mid { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("video_review")]
        public int VideoReview { get; set; }

        [JsonProperty("favorites")]
        public int Favorites { get; set; }

        [JsonProperty("aid")]
        public int Aid { get; set; }

        [JsonProperty("hide_click")]
        public bool HideClick { get; set; }
    }

    public class Data
    {
        [JsonProperty("vlist")]
        public List<VideoList> VideoList { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class UserVideo
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
