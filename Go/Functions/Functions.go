package main

import "fmt"

func main() {
	for i := 0; i < 3; i++ {
		hello()
	}

	Add(5, 6)
	Add(20, 6)

	add(5, 2, 2.4, 12.4, 123.42)
	ADD(4, 5, 7, 1)
	ADD(2, 4)
	var numbers = []int{1, 2, 3, 4, 5}
	ADD(numbers...)
	fmt.Println((ADd(6, 8)))

	var age, name = aDD(4, 5, "Tom", "Simpson")
	fmt.Println(age)
	fmt.Println(name)

	var f func(int, int) int = ADd
	fmt.Println(f(3, 6))
	var x = f(5, 9)
	fmt.Println(x)

	f1 := func(x, y int) int { return x + y }
	fmt.Println(f1(6, 5))
	fmt.Println(f1(14, 16))

	action(10, 25, func(x, y int) int { return x + y })
	action(5, 6, func(i1, i2 int) int { return i1 * i2 })

	f2 := SelectFn(2)
	fmt.Println(f2(19, 20))
	f2 = SelectFn(1)
	fmt.Println(f2(19, 20))
	f2 = SelectFn(21)
	fmt.Println(f2(19, 20))

	f3 := square()
	fmt.Println(f3()) //9
	fmt.Println(f3()) //16
	fmt.Println(f3()) //25

}

func hello() {
	fmt.Println(("Hello world!!!"))
}

func Add(a int, b int) {
	var z = a + b
	fmt.Println("a + b = ", z)
}

func add(a, b int, c, d, e float32) {
	var f = a + b
	var g = c + d + e
	fmt.Println("a + b = ", f)
	fmt.Println("c + d + e = ", g)
}

func ADD(numbers ...int) {
	var sum = 0
	for _, number := range numbers {
		sum += number
	}
	fmt.Println("sum = ", sum)
}

func ADd(x, y int) int {
	return x + y
}

func aDD(x, y int, firstName, lastName string) (int, string) {
	var z = x + y
	var fullName = firstName + " " + lastName
	return z, fullName
}

func action(n1, n2 int, operation func(int, int) int) {
	fmt.Println(operation(n1, n2))
}

func SelectFn(n int) func(int, int) int {
	if n == 1 {
		return func(i1, i2 int) int { return i1 + i2 }
	} else if n == 2 {
		return func(i1, i2 int) int { return i1 - i2 }
	} else {
		return func(i1, i2 int) int { return i1 * i2 }
	}
}
func square() func() int {
	var x int = 2
	return func() int {
		x++
		return x * x
	}
}
