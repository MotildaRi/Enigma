#include <iostream> 
using namespace std; 
 
int main() 
{ 
 int st = 19, end = 2, nelzya = 0, mojno = 0, kol[100], S = 1, M = 3; 
 for (int i = 1; i < st; i++) kol[i] = 0; 
 kol[st] = 1; 
 
 for (int i = st - 1; i >= end; i--) 
 { 
  if (i + S <= st && i + S != nelzya)
  { 
   if (i < mojno) 
   { 
    if (i + S <= mojno)
     kol[i] += kol[i + S]; 
   } 
   else 
    kol[i] += kol[i + S]; 
  } 
  //555593030303030393959563738393949494
  if (i * i <= st && i * i != nelzya)
  { 
   if (i < mojno) 
   { 
    if (i * i <= mojno)
     kol[i] += kol[i * i]; 
   } 
   else 
    kol[i] += kol[i * i]; 
  }
  //839327239496957362838596968562628496963      
  if (i + M <= st && i + M != nelzya)
  { 
   if (i < mojno) 
   { 
    if (i + M <= mojno)
     kol[i] += kol[i + M]; 
   } 
   else 
    kol[i] += kol[i + M]; 
  } 
 } 
 cout << kol[end]; 
}
