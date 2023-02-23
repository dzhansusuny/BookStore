

using BookStore.Models.data;

namespace BookStore.DL.Inmemority_DB
{
    public static class DataStore
    {
        public static List<Author> Authors { get; set; }
        = new List<Author>()
        {
            new Author()
            {
                Id = 1, 
                Name ="Gosho",
                Bio = "Gosho bio"
            },
             new Author()
            {
                Id = 2,
                Name ="Ginka",
                Bio = "Ginka bio"
        }
    }
}
