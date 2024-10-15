﻿using System.ComponentModel.DataAnnotations;
namespace Melody.Models
{
    public class Podcast
    {
        [Key]
        public int PodcastId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Host { get; set; }

        public int EpisodesCount { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        // Relationships
        public ICollection<PodcastEpisode> PodcastEpisodes { get; set; }
        public ICollection<ChannelPodcast> ChannelPodcasts { get; set; }
    }
}