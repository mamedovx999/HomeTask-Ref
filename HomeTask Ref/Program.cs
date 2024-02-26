#region task1
//using System.Text;

//int[] arr;
//Convert(out arr);

//foreach (int num in arr)
//{
//    Console.WriteLine(num + "");
//}
//static void Convert (out int[] arr)
//{
//    arr = new int[] { -23, -43, -32, 34, 32 };
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] < 0)
//        {
//            arr[i] *= -1;
//        }
//    }
//}
#endregion
#region task2
//ReppeatString("Ha", 5);

//static void ReppeatString(string word, int count)
//{
//    StringBuilder sb = new StringBuilder();
//    for (int i = 0;i < count; i++)
//    {
//        sb.Append(word);
//    }
//    Console.WriteLine(sb);
//}
#endregion
#region Task3
//Palindrome("aha");
//static void Palindrome(string word)
//{
//    string NewString = default;
//	for (int i = word.Length - 1; i >= 0; i--)
//	{
//		NewString += word[i];
//	}
//	if (NewString == word)
//	{
//		Console.WriteLine("Palindrome");
//	}
//	else
//	{
//		Console.WriteLine("Palindrome deyil");
//	}
//}
#endregion
#region Task4
//string word = "Memmedeli";
//string result=RemoveDuplicates(word);
//Console.WriteLine(result);
//static string RemoveDuplicates(string word)
//{
//	string result = "";
//	for (int i = 0; i < word.Length; i++)
//	{
//		char c = word[i];
//		bool isDup = false;
//		for (int j = 0; j < result.Length; j++)
//		{
//			if (c == result[j])
//			{
//				isDup = true;
//				break;
//			}
//		}

//		if (isDup == false)
//		{
//			result += c;
//		}
//	}
//	return result;

//}
#endregion
#region Task5
//backwards("Salam");
//static void backwards (string word)
//{
//	string NewString = default;
//	for (int i = word.Length - 1; i >= 0; i--)
//	{
//		NewString += word[i];
//	}
//    Console.WriteLine(NewString);

//}
#endregion
#region Task7

//int[] arr = { 34, 56, 778, 543, 21, 3456 };
//int result = 0;

//for (int write = 0; write < arr.Length; write++)
//{
//    for (int sort = 0; sort < arr.Length - 1; sort++)
//    {
//        if (arr[sort] > arr[sort + 1])
//        {
//            result = arr[sort + 1];
//            arr[sort + 1] = arr[sort];
//            arr[sort] = result;
//        }
//    }
//    Console.Write("{0} ", arr[write]);
//}
#endregion
#region Task8
//Main(args);
//static void Main(string[] args)
//{
//    string input = "Azerbaycan";

//    if (input.Length >= 4)
//    {
//        string firstFourChars = input.Substring(0, 4);
//        Console.WriteLine(firstFourChars);
//    }
//    else
//    {
//        Console.WriteLine();
//    }
//}

#endregion