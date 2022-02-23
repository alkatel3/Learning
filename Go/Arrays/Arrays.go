package main

import "fmt"

func main() {
	var numbers1 [5]int
	fmt.Println(numbers1)
	var numbers2 [5]int = [5]int{1, 2, 3, 4, 5}
	fmt.Println(numbers2)
	var numbers3 [5]int = [5]int{1, 2}
	fmt.Println(numbers3)
	numbers4 := [5]int{1, 2, 3}
	fmt.Println(numbers4)
	var numbers5 = [...]int{1, 2, 3, 4, 5, 6}
	numbers6 := [...]int{1, 2, 3, 4}
	fmt.Println(numbers5)
	fmt.Println(numbers6)
	fmt.Println(numbers1[1], numbers3[4])
	numbers5[5] = 10
	fmt.Println(numbers5[5])

}
