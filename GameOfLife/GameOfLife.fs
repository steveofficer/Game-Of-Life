module GameOfLife

let Tick population = 
    // map the population into a co-ordinate system of rows and columns
    let cord_population =
        let rows = Seq.toArray population
        Array.map Seq.toArray rows

    /// Only get the neighbours of a cell that are alive
    let ``live neighbours`` cell_position = 
        let neighbours = seq {
            let (column, row) = cell_position
//            if row-1 >= 0 then
//                let row_above = cord_population.[row-1]
//                if column-1 >= 0 then
//                    yield row_above.[column-1]
//                yield row_above.[column]
//                if column+1 < row_above.Length then
//                    yield row_above.[column+1]
//        
//            let same_row = cord_population.[row]
//            if column-1 >= 0 then
//                yield same_row.[column-1]
//            if column+1 < same_row.Length then
//                yield same_row.[column+1]
//        
//            if row+1 < cord_population.Length then
//                let row_below = cord_population.[row+1]
//                if column-1 >= 0 then
//                    yield row_below.[column-1]
//                yield row_below.[column]
//                if column+1 < row_below.Length then
//                    yield row_below.[column+1]

            let index_above = (if row-1 >=0 then row-1 else cord_population.Length-1)
            let index_below = (if row+1 < cord_population.Length then row+1 else 0)
            
            let row_above = cord_population.[index_above]
            let left_index = (if column-1 >= 0 then column-1 else row_above.Length-1)
            let right_index = (if column+1 < row_above.Length then column+1 else 0)
            yield row_above.[left_index]
            yield row_above.[column]
            yield row_above.[right_index]
        
            let same_row = cord_population.[row]
            let left_index = (if column-1 >= 0 then column-1 else same_row.Length-1)
            let right_index = (if column+1 < same_row.Length then column+1 else 0)
            yield same_row.[left_index]
            yield same_row.[right_index]
        
            let row_below = cord_population.[index_below]
            let left_index = (if column-1 >= 0 then column-1 else row_below.Length-1)
            let right_index = (if column+1 < row_below.Length then column+1 else 0)
            yield row_below.[left_index]
            yield row_below.[column]
            yield row_below.[right_index]
        }

        neighbours |> Seq.filter (fun c -> c)  |> Seq.length

    /// Determine whether or not a cell is alive
    let ``is cell alive`` cell_position cell = 
        match cell with
        | true -> 
            match ``live neighbours`` cell_position with
            | 2 | 3 -> true
            | _ -> false
        | false ->
             match ``live neighbours`` cell_position with
             | 3 -> true
             | _ -> false
    
    // Map the population into rows, and then map the rows into cells and determine if the cells are alive or dead
    Seq.mapi (fun row cells -> Seq.mapi (fun column cell -> ``is cell alive`` (column, row) cell) cells) cord_population