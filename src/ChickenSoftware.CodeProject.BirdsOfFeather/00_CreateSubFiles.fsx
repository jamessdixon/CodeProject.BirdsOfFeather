
let filePath = @"F:\Git\CodeProject.BirdsOfFeather\data\UserBehaviour.txt"
let lines = System.IO.File.ReadLines(filePath)
lines |> Seq.take(10) |> Seq.iter(fun x -> printfn  "%s" x) 
printfn "Total Length: %i" (lines |> Seq.length)

let tagsPath = @"F:\Git\CodeProject.BirdsOfFeather\data\Tags.txt"
let tagsData = lines |> Seq.skip(2) |> Seq.take(1)
System.IO.File.WriteAllLines(tagsPath,tagsData)

let articlesPath = @"F:\Git\CodeProject.BirdsOfFeather\data\Articles.txt"
let articlesData = lines |> Seq.skip(7) |> Seq.take(3000)
System.IO.File.WriteAllLines(articlesPath,articlesData)

let usersPath = @"F:\Git\CodeProject.BirdsOfFeather\data\Users.txt"
let usersData = lines |> Seq.skip(3011) |> Seq.take(3000)
System.IO.File.WriteAllLines(usersPath,usersData)

let actionsPath = @"F:\Git\CodeProject.BirdsOfFeather\data\Actions.txt"
let actionsData = lines |> Seq.skip(6014)
System.IO.File.WriteAllLines(actionsPath,actionsData)













