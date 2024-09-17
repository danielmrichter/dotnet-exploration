Console.WriteLine(countKata.FriendOrFoe(new [] { "Mark", "Jimmy", "Abel", "Amanda" }));


//solution for: Opposites Attract
// https://www.codewars.com/kata/555086d53eac039a2a000083/train/csharp
public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    {
        if (flower1 % 2 == 0
            && flower2 % 2 == 1)
        {
            return true;
        }
        else if (flower1 % 2 == 1
            && flower2 % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}



// Solution for You Only Need One
// https://www.codewars.com/kata/57cc975ed542d3148f00015b/train/csharp
public class Kata
{
    public static bool Check(object[] a, object x)
    {
        foreach (var entry in a)
        {
            if (entry.Equals(x))
            {
                return true;
            }
        }
        return false;
    }
}



// Solution for Sum of Positives
// https://www.codewars.com/kata/5715eaedb436cf5606000381/train/csharp
public class OtherKata
{
    public static int PositiveSum(int[] arr)
    {
        int sumOfAllPositives = 0;
        foreach (int num in arr)
        {
            if (num > 0)
            {
                sumOfAllPositives = sumOfAllPositives + num;
            }
        }
        return sumOfAllPositives;
    }
}

// For VowelCount
// https://www.codewars.com/kata/54ff3102c1bad923760001f3
public static class VowelCount
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        foreach (var item in str)
        {
            Console.WriteLine($"Item is: {item}");
            if (item.Equals('e') || item.Equals('i') || item.Equals('a') || item.Equals('o') || item.Equals('u'))
                vowelCount++;
        }
        return vowelCount;
    }
}


// For You're a Square!
// https://www.codewars.com/kata/54c27a33fb7da0db0100040e
public class MathKata
{
  public static bool IsSquare(double n)
  {
    double sqrt = Math.Sqrt(n);
    int intsqrt = (int)sqrt;
    if(sqrt == intsqrt)
      return true;
    return false;
  }
}

// For Friend or Foe?
// https://www.codewars.com/kata/55b42574ff091733d900002f
public static class countKata {
  public static IEnumerable<string> FriendOrFoe (string[] names) {
    var Friends = new List<string>();
    foreach(string name in names)
    {
      if(name.Length == 4)
      {
        Friends.Add(name);
      }
    }
    return Friends;
  }
}