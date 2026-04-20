package main 

import (
	"fmt"
	"lang/greetings"
	"log"
)

func main() {


	log.SetPrefix("greetings: ")
    log.SetFlags(0)

	fmt.Println("Hello world")
	mess , er := greetings.Greet("yusuf")
	if (er != nil) {
		log.Fatal("error from greeting")
	}
	fmt.Println(mess)
}