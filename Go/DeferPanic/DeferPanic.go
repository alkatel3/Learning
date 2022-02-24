package main

import "fmt"

func main() {
	ExampleDefer()
	ExamplePanic()
}
func finish() {
	fmt.Println("Program has been finished")
}
func Part1() {
	defer fmt.Println("Part1 has been finished") //3
	defer fmt.Println("Part1 has been started")  //2
	fmt.Println("Part1 is working")              //1
}
func ExampleDefer() {
	defer finish()                               //4
	fmt.Println("ExampleDefer has been started") //1
	Part1()                                      //2
	fmt.Println("ExampleDefer is working")       //3
}
func ExamplePanic() {
	fmt.Println(divide(4, 3))
	divide(9, 0)
	finish()
}
func divide(x, y float64) float64 {
	if y == 0 {
		panic("Division dy zero!")
	}
	return x / y
}
