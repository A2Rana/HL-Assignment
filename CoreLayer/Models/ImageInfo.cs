using System;

namespace ModelsDTOLayer
{
    public class ImageInfo
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string ColorType { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public Int16 Width { get; set; }
        public Int16 Height { get; set; }
        public int Sequence { get; set; }
        public string ObjectLabels { get; set; }

    }

}
