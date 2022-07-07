package main

import "fmt"

func main() {
	var a = 4
	var b = 6
	var c = a + b
	fmt.Println(c)
	c = a - b
	fmt.Println(c)
	c = a * b
	fmt.Println(c)
	c = a / b
	fmt.Println(c)
	var e float32 = 4
	var f float32 = 6
	var h float32 = e / f
	fmt.Println(h)
	c = b % a
	fmt.Println(c)
	c++
	fmt.Println(c)
	c--
	fmt.Println(c)
}
