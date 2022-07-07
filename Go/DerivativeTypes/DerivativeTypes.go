package main

import "fmt"

type mile int
type kilometer int
type library []string

func main() {
	var distance mile = 5
	fmt.Println(distance)
	distance += 5
	fmt.Println(distance)
	distanceToEnemy(distance)

	//var distance2 kilometer=5
	//distanceToEnemy(distance2)    error
	var myLibrary library = library{"Book1", "Book2", "Book3"}
	printBooks(myLibrary)

}

func distanceToEnemy(distance mile) {
	fmt.Println("Distance for the enemy")
	fmt.Println(distance, "mile")
}

func printBooks(lib library) {
	for _, value := range lib {
		fmt.Println(value)
	}
}
