package greetings

import "fmt"

func Greet(name string) string {
	//var message string 

	message := fmt.Sprintf("Hello %v", name)

	return message
}
