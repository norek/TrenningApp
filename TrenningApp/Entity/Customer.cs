namespace TrenningApp.Entity
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Id: {0}   Name: {1}", Id, Name);
        }
    }
}