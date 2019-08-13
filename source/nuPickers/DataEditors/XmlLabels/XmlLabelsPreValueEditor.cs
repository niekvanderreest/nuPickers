﻿namespace nuPickers.DataEditors.XmlLabels
{
    using nuPickers.EmbeddedResource;
    using Umbraco.Core.PropertyEditors;

    internal class XmlLabelsPreValueEditor : PreValueEditor
    {
        [PreValueField("dataSource", "", EmbeddedResource.ROOT_URL + "XmlDataSource/XmlDataSourceConfig.html", HideLabel = true)]
        public string DataSource { get; set; }

        [PreValueField("customLabel", "", EmbeddedResource.ROOT_URL + "CustomLabel/CustomLabelConfig.html", HideLabel = true)]
        public string CustomLabel { get; set; }

        /// <summary>
        /// currently no ui, but forces controller to be loaded
        /// </summary>
        [PreValueField("labels", "", EmbeddedResource.ROOT_URL + "Labels/LabelsConfig.html", HideLabel = true)]
        public string Labels { get; set; }

        [PreValueField("layoutDirection", "Layout Direction", EmbeddedResource.ROOT_URL + "LayoutDirection/LayoutDirectionConfig.html")]
        public string LayoutDirection { get; set; }
    }
}
