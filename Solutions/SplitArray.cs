namespace Logica.Solutions
{
    public class SplitArray
    {
        public static void ArraySpliter(List<dynamic> list, int fractions)
        {
            List<List<dynamic>> result = new List<List<dynamic>>();
            List<dynamic> splits = new List<dynamic>();

            string consoleResult = "";

            for (int i = 0; i < list.Count; i++)
            {
                splits.Add(list[i]);

                if (splits.Count == fractions)
                {
                    result.Add(new List<dynamic>(splits));
                    splits.Clear();
                }

                if (splits.Count < fractions && splits.Count > 0 && i == list.Count - 1)
                {
                    result.Add(new List<dynamic>(splits));
                    splits.Clear();
                }
            }

            foreach (var sublist in result)
            {
                consoleResult += "[ " + string.Join(", ", sublist) + " ],";
            }

            Console.WriteLine($"[{consoleResult}]");
        }
    }
}
