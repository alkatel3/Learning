package main

import "fmt"

type person struct {
	name string
	age  int
}

func (p *person) updateAge(newAge int) {
	p.age = newAge
}
func (p person) print() {
	fmt.Println("Name:", p.name)
	fmt.Println("Age:", p.age)
}
func (p person) eat(meal string) {
	fmt.Println(p.name, "is eattig", meal)
}

type library []string

func main() {
	var lib library = library{"book1", "book2", "book3"}
	lib.print()

	var tom = person{"Tom", 18}
	tom.print()
	tom.eat("sup")
	tom.updateAge(23)
	tom.print()

}

func (l library) print() {
	for _, val := range l {
		fmt.Println(val)
	}
}
