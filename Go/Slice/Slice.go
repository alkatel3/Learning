package main

import (
	"fmt"
)

func main() {
	var users1 []string
	users1 = []string{"Tom", "Alice", "Kate"}

	var users2 = []string{"Tom", "Alice", "Kate"}

	users3 := []string{"Tom", "Alice", "Kate"}

	var users4 = make([]string, 3)
	users4[0] = "Tom"
	users4[1] = "Alice"
	users4[2] = "Kate"

	fmt.Println(users1[2])

	for _, value := range users3 {
		fmt.Println(value)
	}

	users2 = append(users2, "Bob")
	for _, value := range users2 {
		fmt.Println(value)
	}

	users := []string{"Tom", "Alice", "Kate", "Sam", "Bob", "Paul", "Mike", "Robert"}

	users5 := users[2:6]
	users6 := users[:4]
	users7 := users[4:]
	fmt.Println(users5)
	fmt.Println(users6)
	fmt.Println(users7)

	fmt.Println(users)
	users = append(users[:3], users[4:]...)
	fmt.Println(users)
}
