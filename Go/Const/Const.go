package main

import "fmt"

func main() {
	const pi1 float64 = 3.1415
	//pi=2.22323 error
	const (
		e   float64 = 2.7182
		pi2 float64 = 3.1415
	)
	const pi3, e2 = 3.1415, 2.7182
	const n = 5
	const (
		a = 1
		b
		c
		d = 3
		f
	)
	fmt.Println(pi1)
	fmt.Println(pi2, " ", e)
	fmt.Println(pi3, " ", e2)
	fmt.Println(a, b, c, d, f)

}
