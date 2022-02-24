package main

import "fmt"

func main() {
	var hello string
	hello = "hello"
	var Hello string = "Hello"
	var (
		name string = "Tom"
		age  int    = 27
	)
	fmt.Println(hello)
	fmt.Println(Hello)
	fmt.Println(name, age)
	name = "Oleg"
	fmt.Println(name)
	number := 10.12
	fmt.Println(number)

	var a int8 = -1
	var b uint8 = 2
	var c byte = 3
	var d int16 = -4
	var e uint16 = 5
	var f int32 = -6
	var g rune = -7
	var h uint32 = 8
	var i int64 = -9
	var j uint64 = 10
	var k int = 102
	var l uint = 105
	fmt.Println(a, " ", b, " ", c, " ", d, " ", e, " ", f, " ",
		g, " ", h, " ", i, " ", j, " ", k, " ", l)
	var n float32 = 18
	var m float32 = 4.5
	var o float64 = 0.23
	var pi float64 = 3.14
	var q float64 = 2.7
	fmt.Println(n, " ", m, " ", o, " ", pi, " ", q)
	var (
		r complex64  = 1 + 2i
		s complex128 = 4 + 3i
	)
	fmt.Println(r, " ", s)
	var (
		isAlive   bool = true
		isEnabled bool = false
	)
	fmt.Println(isAlive, " ", isEnabled)
}
