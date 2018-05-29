/*
Copyright (c) 2018-present, Walmart Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

//  ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Walmart.Sdk.Marketplace.V2.Payload.Feed
{
    using System.Xml.Serialization;
    using System.Xml;
    using System.Collections.Generic;
    using Walmart.Sdk.Base.Primitive;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.4.0.7")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://walmart.com/")]
    [XmlRootAttribute(Namespace="http://walmart.com/", IsNullable=false)]
    public class ItemFeedResponse : BasePayload
    {
        /// <summary>
        /// UUID - a correlation id to partners so that they can query the status and response later for the feed
        /// </summary>
        [XmlElement("feedId")]
        public string FeedId { get; set; }
        /// <summary>
        /// overall status of the request. Item statuses are in items detail.
        /// </summary>
        [XmlElement("feedStatus")]
        public FeedStatus FeedStatus { get; set; }
        /// <summary>
        /// errors
        /// </summary>
        [XmlArrayItemAttribute("ingestionError", IsNullable = false)]
        [XmlArray("ingestionErrors")]
        public List<IngestionError> IngestionErrors { get; set; }
        /// <summary>
        /// how many components were found in the feed
        /// </summary>
        [XmlElement("itemsReceived")]
        public int ItemsReceived { get; set; }
        /// <summary>
        /// how many items succeeded
        /// </summary>
        [XmlElement("itemsSucceeded")]
        public int ItemsSucceeded { get; set; }
        /// <summary>
        /// how many items ended in error, due to data error or system error, exact error type will be indicated by error code for the item
        /// </summary>
        [XmlElement("itemsFailed")]
        public int ItemsFailed { get; set; }
        /// <summary>
        /// how many items are still being processed?
        /// </summary>
        [XmlElement("itemsProcessing")]
        public int ItemsProcessing { get; set; }
        /// <summary>
        /// index of the first item status being reported in this response, 0 based offset, used for response pagination of large feeds
        /// </summary>
        [XmlElement("offset")]
        public int Offset { get; set; }
        /// <summary>
        /// number of items being reported in this response, used for response pagination of large feeds
        /// </summary>
        [XmlElement("limit")]
        public int Limit { get; set; }
        /// <summary>
        /// partner generated and provided ID of the feed
        /// </summary>
        [XmlElement("requestId")]
        public string RequestId { get; set; }
        /// <summary>
        /// partner generated and provided ID of the feed
        /// </summary>
        [XmlElement("requestBatchId")]
        public string RequestBatchId { get; set; }
        /// <summary>
        /// additional attributes bag, content will depend on partner type
        /// </summary>
        [XmlArrayItemAttribute("NameValueAttribute", IsNullable = false)]
        [XmlArray("additionalAttributes")]
        public List<MPNameValueAttribute> AdditionalAttributes { get; set; }
        /// <summary>
        /// Indicates detailed response for the feed
        /// </summary>
        [XmlArrayItemAttribute("itemIngestionStatus", IsNullable = false)]
        [XmlArray("itemDetails")]
        public List<GenericItemIngestionStatus> ItemDetails { get; set; }
    
        /// <summary>
        /// ItemFeedResponse class constructor
        /// </summary>
        public ItemFeedResponse()
        {
            ItemDetails = new List<GenericItemIngestionStatus>();
            AdditionalAttributes = new List<MPNameValueAttribute>();
            IngestionErrors = new List<IngestionError>();
        }
    }
}