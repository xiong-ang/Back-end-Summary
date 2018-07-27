# Back-end Technology Summary             
> 总结了**中用到的一些后端技术              

## Ajax Request              
> .Net 发送Ajax请求                
* HttpClient     
* HttpRequestMessage       
* HttpClient.SendAsync()         
* HttpResponseMessage            

## Download                   
> .Net 实现文件下载       
* WebClient       
* WebClient.DownloadFileTaskAsync()      
* WebClient.CancelAsync()              

## C# Call C++ By C++/CLI            
> 用过C++/CLI实现C#调用C++             

## TaskManager             
> 多线程任务管理器                  
* Task      

## UriParamsComposer               
> 实现Uri的相关处理                   
* Uri              

## Newtonsoft.Json            
> 实现JSon的序列化与反序列化接口                
* Template      
* Interface           
```
Interface IJson
{
    Object FromJson(string json);
    string ToJson(Object obj);
}
```
## Get Computer IP Address         
> 获取本机IP              
* Dns         

## Get Available port               
> 获取本机的可用端口                  
* IPGlobalProperties                   
