

int[] nums = { 0, 1, 1,0,1,0,1,1,1 };
int TotalOnes = 0;
List<int> Consec = new List<int>();

for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 1)
        {
            TotalOnes++;
        }
        if (nums[i] == 0 && i != (nums.Length - 1))
        {
        Consec.Add(TotalOnes);
            TotalOnes = 0;
        }
        if(i == (nums.Length - 1))
        {
            Consec.Add(TotalOnes);
        }
   }
Console.WriteLine(Consec.Max());