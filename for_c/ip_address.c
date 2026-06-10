#ifdef _WIN64
// seif code
#endif

#ifdef __linux__
// yusuf code 

#include<sys/socket.h>
#include<netinet/in.h>
#include<arpa/inet.h>
#include<stdio.h>
#include<netdb.h> 

#define URL "https://api.ipify.org"

int get_ip_address() 
{


    /**
     * steps to make a tcp request 
     *
     * create - socketpair a sockets 
     *
     * bind - connect - listen - accept
     *
     * getsocketname - getpeernam
     * 
     * revc - recvfrom - recvmsg 
     * */


    //create a web socket
    int sok = socket(AF_UNIX, SOCK_STREAM, SHUT_RDWR);

    //for handling errors
    if(sok < 0) {
        printf("Error in socket creating in get_ip_address function \n");
    }

    //resolve the URL to address

    struct hostent* host = gethostbyname(URL);

    if(host) {
        printf("cannot resolve the url in get_ip_address\n");
    }
    
    int address_length_in_bytes = host->h_length;
    int address_type = host->h_addrtype;
    //h_name address_name = host->h_name;

    //create the sockaddr

    struct sockaddr_in sk;
    struct sockaddr* skdr;
    socklen_t* skt;
    
    sk.sin_addr = host->h_addr_list[0];
    int er = getsockname(sok, skdr, skt);
    if(!er){
        printf("error fill the sockaddr \n");
    }

    //now lets connect

    int connection_error = connect(sok, host, 
            address_length_in_bytes);

    if(!connection_error){
        printf("error in connect function in get_ip_address\n");
    }




























    //define server address int the sockaddr_in strcut 

    struct sockaddr_in sokaddress;

    //sokaddress.sin_port = URL;

    char* response_body_buffer[255];

    ssize_t result = recv(sok, response_body_buffer, 255, MSG_WAITALL);
   
    return 0;
}

int main(){ return 0; }


#endif
