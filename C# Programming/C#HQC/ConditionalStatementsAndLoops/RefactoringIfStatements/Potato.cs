namespace RefactoringIfStatements
{
    class Potato
    {
        static void Cook()
        {
            //Before refactoring:
            //Potato potato;
            ////... 
            //if (potato != null)
            //    if (!potato.HasNotBeenPeeled && !potato.IsRotten)
            //        Cook(potato);

            //After refactoring:
            Potato potato;
            //... 
            if (potato != null)
            {
                if (!(potato.HasNotBeenPeeled || potato.IsRotten))
                {
                    Cook(potato);
                }                
            }
        }
    }
}
