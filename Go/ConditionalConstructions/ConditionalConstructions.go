package main

import "fmt"

func main() {
	a := 6
	b := 5
	if a < b {
		fmt.Println("a is less than b")
	} else if a > b {
		fmt.Println("b is less than a")
	} else {
		fmt.Println("a is equal to b")
	}
	switch a {
	case 1:
		fmt.Println("a = 1")

	case 2, 3, 4:
		fmt.Println("a = 2 or 3 or 4")
	case 5:
		fmt.Println("a = 5")

	case 6:
		fmt.Println("a = 6")
	default:
		fmt.Println("HZ")
	}
	for i := 0; i < 15; i++ {
		if i%2 == 0 {
			fmt.Println(i)
		}
	}
	var names [3]string = [3]string{"Tom", "Oleg", "Olya"}
	for index, value := range names {
		fmt.Println(index, value)
	}
	for _, value := range names {
		fmt.Println(value)
	}
	for i := 0; i < len(names); i++ {
		fmt.Println(names[i])
	}

}
