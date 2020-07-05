#include <iostream>
using namespace std;
void nhap(double *a,int n){
	for(int i=0;i<n;i++){
		cout<<"\n nhap a["<<i+1<<"]:";
		cin>>a[i];
	}
}
double min(double *a,int n){
	if(n==1)
	  return a[n-1];
    else{
    	if(a[n-1]<min(a,n-1))
    	  return a[n-1];
  	    else 
  	    return min(a,n-1);
    }
}
int main(){
	int n;
	cout<<"\n ban hay nhap vao so phan tu cua mang:";
	cin>>n;
	double *a=new double[n];
	nhap(a,n);
	cout<<"\n min cua day so la:"<<min(a,n);
	return 0;
}