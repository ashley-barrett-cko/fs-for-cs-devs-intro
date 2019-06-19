module OrderService
    //Records
    type Customer = { FirstName:string; LastName:string; Age:int }
    type Order = { OrderId:int; Customer:Customer }

    //Enums
    type Colours = 
    | Green
    | Red
    | Blue

    //Choices
    type OrderResponse<'t> =
    | Accepted of Order
    | Rejected
    | Error of (int * string) list
    | Generic of 't

    //Class
    type Product(code, price) = 
       let isFree = price = 0.0 
       new (code) = Product(code, 0.0)
       
       member this.Code = code 
       member this.IsFree = isFree

    let processOrder customer productName = 

        match productName with
        | "Kettle" -> { OrderId = 1; Customer = customer } |> Accepted
        | "Toaster" -> Rejected
        | _ -> [(1,"error_message_1"); (2, "error_message_2")] |> Error
  
