package main

import "fmt"

func main() {
	var x int = 10
	var p *int
	p = &x
	fmt.Println(p)
	fmt.Println(*p)
	*p = 25
	fmt.Println(x)

	i := new(int)
	fmt.Println(*i)
	*i = 8
	fmt.Println(*i)

	f := 2.5
	fp := &f
	fmt.Println(*fp)

	f1 := 5
	fp1 := &f1

	fmt.Println(f1)
	changeValue1(f1)
	fmt.Println(f1)
	changeValue2(fp1)
	fmt.Println(f1)

	p1 := createPointer(7)
	fmt.Println(*p1)
	p2 := createPointer(15)
	fmt.Println(*p2)
	p3 := createPointer(30)
	fmt.Println(*p3)

}
func changeValue1(x int) {
	x = x * x
}
func changeValue2(x *int) {
	*x = (*x) * (*x)
}
func createPointer(x int) *int {
	p := new(int)
	*p = x
	return p
}
