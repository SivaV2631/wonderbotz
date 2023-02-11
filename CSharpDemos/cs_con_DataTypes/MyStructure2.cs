namespace cs_con_DataTypes
{
    /// <summary>
    ///     1. Default Constructor for the Structure is ALWAYS ADDED by the Language Compiler.
    ///        Language Compiler will initialize members to DEFAULT value of 0, FALSE or NULL;
    ///     2. Default Constructor is called implicitly during the Declaration process.
    ///     3. Use a constructor only when you have private data members in the Structure!
    ///     4. ALL MEMBERS of the structure HAVE TO BE INITIALIZED in every Developer specified Constructor.
    /// </summary>
    internal struct MyStructure2
    {
        public MyStructure2(int i, string s)
        {
            this.ID = i;
            this.Name = s;
            this.CompanyName = s;
        }

        public int ID;

        public string Name;

        public string CompanyName;
    }
}
