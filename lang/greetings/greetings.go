package greetings

import (
	"errors"
	"fmt"
	"math/rand"
)

func Greet(name string) (string, error) {
	//var message string 
	if name == "" {
		return name, errors.New("name is empty")
	}

	message := fmt.Sprintf(randomize(), name)

	return message, nil
}


func randomize() string {
	chunks := [] string {
		"Hello Mstr: %v",
		"hi %v", 
		"greeting for %v",
	}
	return chunks[rand.Intn(len(chunks))]

}