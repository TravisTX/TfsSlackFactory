﻿using System;
using Newtonsoft.Json;

namespace TfsSlackFactory.Models
{

    public class Message
    {
        public string Text { get; set; }
        public string Html { get; set; }
        public string Markdown { get; set; }
    }

    public class PropertyChanged<T>
    {
        public T OldValue { get; set; }
        public T NewValue { get; set; }
    }

    public class ResourceFields
    {
        [JsonProperty("System.Rev")]
        public PropertyChanged<string> Rev { get; set; }
        [JsonProperty("System.AuthorizedDate")]
        public PropertyChanged<DateTime> AuthorizedDate { get; set; }
        [JsonProperty("System.RevisedDate")]
        public PropertyChanged<DateTime> RevisedDate { get; set; }
        [JsonProperty("System.State")]
        public PropertyChanged<string> State { get; set; }
        [JsonProperty("System.Reason")]
        public PropertyChanged<string> Reason { get; set; }
        [JsonProperty("System.AssignedTo")]
        public PropertyChanged<string> AssignedTo { get; set; }
        [JsonProperty("System.ChangedDate")]
        public PropertyChanged<DateTime> ChangedDate { get; set; }
        [JsonProperty("System.Watermark")]
        public PropertyChanged<string> Watermark { get; set; }
        [JsonProperty("Microsoft.VSTS.Common.Severity")]
        public PropertyChanged<string> Severity { get; set; }
    }

    public class Link
    {
        public string Href { get; set; }
    }

    public class Links
    {
        public Link Self { get; set; }
        public Link Parent { get; set; }
        public Link WorkItemUpdates { get; set; }
    }

    public class RevisionFields
    {
        [JsonProperty("System.AreaPath")]
        public string AreaPath { get; set; }
        [JsonProperty("System.TeamProject")]
        public string TeamProject { get; set; }
        [JsonProperty("System.IterationPath")]
        public string IterationPath { get; set; }
        [JsonProperty("System.WorkItemType")]
        public string WorkItemType { get; set; }
        [JsonProperty("System.State")]
        public string State { get; set; }
        [JsonProperty("System.Reason")]
        public string Reason { get; set; }
        [JsonProperty("System.CreatedDate")]
        public string CreatedDate { get; set; }
        [JsonProperty("System.CreatedBy")]
        public string CreatedBy { get; set; }
        [JsonProperty("System.ChangedDate")]
        public string ChangedDate { get; set; }
        [JsonProperty("System.ChangedBy")]
        public string ChangedBy { get; set; }
        [JsonProperty("System.Title")]
        public string Title { get; set; }
        [JsonProperty("Microsoft.VSTS.Common.Severity")]
        public string Severity { get; set; }
        [JsonProperty("WEF_EB329F44FE5F4A94ACB1DA153FDF38BA_Kanban.Column")]
        public string Column { get; set; }
    }

    public class Revision
    {
        public int Id { get; set; }
        public int Rev { get; set; }
        public RevisionFields Fields { get; set; }
        public string Url { get; set; }
    }

    public class Resource
    {
        public int Id { get; set; }
        public int WorkItemId { get; set; }
        public int Rev { get; set; }
        public object RevisedBy { get; set; }
        public string RevisedDate { get; set; }
        public ResourceFields Fields { get; set; }
        [JsonProperty("_links")]
        public Links Links { get; set; }
        public string Url { get; set; }
        public Revision Revision { get; set; }
    }

    public class RootObject
    {
        public string Id { get; set; }
        public string EventType { get; set; }
        public string PublisherId { get; set; }
        public Message Message { get; set; }
        public Message DetailedMessage { get; set; }
        public Resource Resource { get; set; }
        public string CreatedDate { get; set; }
    }

}