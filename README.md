# Test task #1
Тестовое задание C#

Дан List<uint> list и некое число ulong sum. Ожидаемое количество элементов в list - несколько миллионов. Необходимо написать метод FindElementsForSum, который сможет найти наименьшие индексы start и end такие, что сумма элементов list начиная с индекса start включительно и до индекса end не включительно будет в точности равна sum. Если таких start и end нельзя найти, то установить start и end равными 0. Решение предоставить в виде метода. Сигнаруту и название метода менять нельзя, только тело.

public void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
{
	// your code here
}
Примеры:

FindElementsForSumTest(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 11, out start, out end); //start будет равен 5 и end 7;

![image](https://user-images.githubusercontent.com/121448673/232237866-0002a359-2581-492c-bbe4-e66948cda9f6.png)

FindElementsForSumTest(new List<uint> { 4, 5, 6, 7 }, 18, out start, out end); //start будет равен 1 и end 4;

![image](https://user-images.githubusercontent.com/121448673/232237887-6bef64ba-1837-4681-9a27-231ad000fd9e.png)

FindElementsForSumTest(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 88, out start, out end); //start будет равен 0 и end 0;

![image](https://user-images.githubusercontent.com/121448673/232237909-50fa20aa-f892-486f-8578-df8f1f4142ed.png)

FindElementsForSumTest(new List<uint> { 6, 0, 4, 1, 5, 10 }, 11, out start, out end); 

![image](https://user-images.githubusercontent.com/121448673/232237929-2238f457-9919-4211-aa6b-f5274432be90.png)
