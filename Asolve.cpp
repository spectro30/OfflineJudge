#include <bits/stdc++.h>
using namespace std;
long long F[100];

int main(int argc, char const *argv[]) {
    F[1] = 0;
    F[2] = 1;
    for(int i=3;i<=50;i++){
        F[i] = F[i-1] + F[i-2];
    }
    int n;
    while(cin>>n){
        cout<<"Output "<<F[F[n]]<<endl;
    }
    return 0;
}
