package main

import "fmt"

type contact struct {
	email string
	phone string
}

type person struct {
	name string
	age  int
	contact
}

type node struct {
	value int
	next  *node
}

func printNodeValue(n *node) {
	fmt.Println(n.value)
	if n.next != nil {
		printNodeValue(n.next)
	}
}
func main() {
	var tom = person{
		name:    "Tom",
		age:     24,
		contact: contact{email: "alaktel-3@ukr.net", phone: "0678369164"},
	}
	tom.email = "alkatel-3@gmail.com"
	fmt.Println(tom.email)
	fmt.Println(tom.phone)

	first := node{value: 4}
	second := node{value: 5}
	third := node{value: 6}
	first.next = &second
	second.next = &third
	var current *node = &first

	if current != nil {
		printNodeValue(current)
	}
}
