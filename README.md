# Test task #1
Тестовое задание C#

Дан List<uint> list и некое число ulong sum. Ожидаемое количество элементов в list - несколько миллионов. Необходимо написать метод FindElementsForSum, который сможет найти наименьшие индексы start и end такие, что сумма элементов list начиная с индекса start включительно и до индекса end не включительно будет в точности равна sum. Если таких start и end нельзя найти, то установить start и end равными 0. Решение предоставить в виде метода. Сигнаруту и название метода менять нельзя, только тело.

public void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
{
	// your code here
}
Примеры:

FindElementsForSumTest(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 11, out start, out end); //start будет равен 5 и end 7;
FindElementsForSumTest(new List<uint> { 4, 5, 6, 7 }, 18, out start, out end); //start будет равен 1 и end 4;
FindElementsForSumTest(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 88, out start, out end); //start будет равен 0 и end 0;

![image](https://user-images.githubusercontent.com/121448673/232237683-85ecdc1e-afaf-4793-aa3d-9d8e43836727.png)

