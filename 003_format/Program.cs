int x = 10, y = 20;
Console.WriteLine("HELLO WORLD");
Console.WriteLine("x = " + x + ",y = " + y);    //괄호 안 내용을 문자열로 출력하도록 되어있다

// 포맷으로 출력
// 10 이하의 소수 : 2, 3, 5, 7
Console.WriteLine("10 이하의 소수 : 2, 3, 5, 7");
Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3 ,5 ,7);
// printf("%d, %d, %d, %d, 2, 3, 5, 7);