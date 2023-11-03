namespace ProductClass
{
    internal class Book : Product
    {
        public string genre;

        public Book(int no, string name, int price, string genre) : base(no, name, price)
        {
            this.genre = genre;
        }
    }
}
