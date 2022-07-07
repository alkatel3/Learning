package main

import "fmt"

func main() {
	var people = map[string]int{
		"Tom":   1,
		"Bob":   2,
		"Sam":   4,
		"Alice": 8,
	}
	fmt.Println(people)
	fmt.Println(people["Alice"])
	fmt.Println(people["Tom"])
	people["Tom"] = 32
	fmt.Println(people["Tom"])
	if val, ok := people["Tom"]; ok {
		fmt.Println(val)
	}
}
