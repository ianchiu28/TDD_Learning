# TDD_Learning
Learning TDD!

# 學習資源
91哥 - 30天快速上手TDD

# 連結
https://ithelp.ithome.com.tw/articles/10109845

## Notes
* Day 3  
> Ctrl+R, T: 執行單一測試  
> Ctrl+R, A: 執行所有測試（開發時最常使用）  
> Ctrl+R, Ctrl+T: 偵錯單一測試（測試失敗時，最常使用）  
> Ctrl+R, Ctrl+A: 偵錯所有測試  
> 
> 單元測試3A原則：  
> Arrange: 初始化目標物件、相依物件、方法參數、預期結果，或是預期與相依物件的互動方式  
> Act: 呼叫目標物件的方法  
> Assert: 驗證是否符合預期  

* Day 5  
> 隔離相依性: 使用 IoC (介面 + 測試用類別) 去隔離相依性  

* Day 7  
> 使用 Rhino.Mocks 幫助建設 Stub 和 Mock 加速撰寫 Unit Test 速度  
> Stub 使用時機: 1. 驗證回傳 2. 驗證狀態改變  
> Mock 使用時機: 1. 驗證"目標物件"和"相依物件"的互動