using E01D.Samples.Architecture.ObjectContext1.Api.Layers;

namespace E01D.Samples.Architecture.ObjectContext1.Api
{
    public class LayerApi
    {
        public WebEntryLayer Web { get; set; } = new WebEntryLayer();

        public BusinessLayer Business { get; set; } = new BusinessLayer();

        public DataLayer Data { get; set; } = new DataLayer();
    }
}
