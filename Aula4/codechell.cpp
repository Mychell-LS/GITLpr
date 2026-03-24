#include <iostream>
using namespace std;

int call(){
    int x;
    cout<< "Sao multiplos ou nao sao multiplos"<<endl;
    cout<< "Digite um numero: ";
    cin>>x;
     int y;
    cout<< "Digite outro numero: ";
    cin>>y;
    if (x%y==0||y%x==0){

       cout<<"Sao Multiplos"<<endl;  
    }
    else {

        cout<<"Nao sao Multiplos"<<endl;  
    }
    return 0;
}
    