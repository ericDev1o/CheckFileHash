namespace MPTronicCodinGame.Tests;

public class SearchIntInArrayTest
{
    private TimeSpan _timeSpan;
    private bool _result;
    /*
    <summary>
    This tests asserts that the main array integer search works.
    The method must return a positive TimeSpan used by the runtime print method.
    To have a significant runtime with the sequential implementation the minimal array size is a million integers.
    </summary>
    */
    [Fact]
    public void IsIntInArrayOK()
    {
        //Arrange
        using(SearchIntInArray searchIntInArray = DryArrange(1000000,"sequential",95))
        {
        //Act
            if
            (
                searchIntInArray.SearchMode != null
                &&
                searchIntInArray.StopWatch != null 
                && 
                searchIntInArray.Ints != null
            )
                _timeSpan = SearchIntInArray.IsIntInArray
            (
                searchIntInArray.Ints,
                searchIntInArray.NumberToFind,
                searchIntInArray.StopWatch,
                searchIntInArray.SearchMode
            );
        //Assert
            Assert.True(_timeSpan.Milliseconds > 0 || _timeSpan.Seconds > 0 || _timeSpan.Minutes > 0);
        }
    }

    /*
    <summary>
    This test asserts that in sequential search mode 5 is found in the array of size 10 
    filled in ascending index order 0,1,...
    </summary>
    */
    [Fact]
    public void ExistsSequentialSearchModeOK()
    {
        //Arrange
        using(SearchIntInArray searchIntInArray = DryArrange(10,"sequential",50))
        {
        //Act
            if
            (
                searchIntInArray.SearchMode != null
                &&
                searchIntInArray.Ints != null
            )
                _result = SearchIntInArray.Exists(searchIntInArray.Ints,searchIntInArray.NumberToFind,searchIntInArray.SearchMode);
        //Assert
            Assert.True(_result);
        }
    }
    /*
    <summary>
    This test asserts that in sequential search mode 11 isn't found in the array of size 10 
    filled in ascending index order 0,1,...
    </summary>
    */
    [Fact]
    public void ExistsSequentialSearchModeKO()
    {
        //Arrange
        using(SearchIntInArray searchIntInArray = DryArrange(10,"sequential",50))
        {
            searchIntInArray.NumberToFind = 11;
        //Act
            if
            (
                searchIntInArray.SearchMode != null
                &&
                searchIntInArray.Ints != null
            )
                _result = SearchIntInArray.Exists(searchIntInArray.Ints,searchIntInArray.NumberToFind,searchIntInArray.SearchMode);
        //Assert
            Assert.False(_result,"11 is not in the array.");
        }
    }
    /*
    <summary>
    This test asserts that in sequential search mode the search execution time is "reasonable" (arbitrarily 5 seconds)
    in the case where the integer to find is at the 95% index place in the array (position 95 in a 100 sized array)
    </summary>
    */
    [Fact(Timeout = 5000)]
    public void ExistsSequentialSearchModeFastEnoughOK()
    {
        //Arrange
        using(SearchIntInArray searchIntInArray = DryArrange(1000000,"sequential",95))
        {
        //Act
            if
            (
                searchIntInArray.SearchMode != null
                &&
                searchIntInArray.Ints != null
            )
                _result = SearchIntInArray.Exists(searchIntInArray.Ints,searchIntInArray.NumberToFind,searchIntInArray.SearchMode);
        //Assert
        }
    }
    /*
    <summary>
    This test asserts that in sequential search mode the search execution time is "reasonable" (arbitrarily 5 seconds)
    in the case where the integer to find is at the 95% index place in the array (position 95 in a 100 sized array)
    </summary>
    */
    [Fact(Timeout = 5000)]
    public void ExistsSequentialSearchModeFastEnoughKO()
    {
        //Arrange
        using(SearchIntInArray searchIntInArray = DryArrange(1000000,"sequential",95))
        {
            searchIntInArray.NumberToFind = 11;
        //Act
            if
            (
                searchIntInArray.SearchMode != null
                &&
                searchIntInArray.Ints != null
            )
                _result = SearchIntInArray.Exists(searchIntInArray.Ints,searchIntInArray.NumberToFind,searchIntInArray.SearchMode);
        //Assert
        }
    }
    /*
    <summary>
    This test asserts that in dichotomy search mode 5 is found in the array of size 10 
    filled in ascending index order 0,1,...
    </summary>
    */
    [Fact]
    public void ExistsDichotomySearchModeOK()
    {
        //Arrange
        using(SearchIntInArray searchIntInArray = DryArrange(10,"dichotomy",50))
        {
        //Act
            if
            (
                searchIntInArray.SearchMode != null
                &&
                searchIntInArray.Ints != null
            )
                _result = SearchIntInArray.Exists(searchIntInArray.Ints,searchIntInArray.NumberToFind,searchIntInArray.SearchMode);
        //Assert
            Assert.True(_result);
        }
    }
    /*
    <summary>
    This test asserts that in dichotomy search mode 11 isn't found in the array of size 10 
    filled in ascending index order 0,1,...
    </summary>
    */
    [Fact]
    public void ExistsDichotomySearchModeKO()
    {
        //Arrange
        using(SearchIntInArray searchIntInArray = DryArrange(10,"dichotomy",50))
        {
            searchIntInArray.NumberToFind = 11;
        //Act
            if
            (
                searchIntInArray.SearchMode != null
                &&
                searchIntInArray.Ints != null
            )
                _result = SearchIntInArray.Exists(searchIntInArray.Ints,searchIntInArray.NumberToFind,searchIntInArray.SearchMode);
        //Assert
            Assert.False(_result,"11 is not in the array.");
        }
    }
    /*
    <summary>
    This test asserts that in sequential search mode the search execution time is "reasonable" (arbitrarily 5 seconds)
    in the case where the integer to find is at the 95% index place in the array (position 95 in a 100 sized array)
    </summary>
    */
    [Fact(Timeout = 5000)]
    public void ExistsDichotomySearchModeFastEnoughOK()
    {
        //Arrange
        using(SearchIntInArray searchIntInArray = DryArrange(1000000,"dichotomy",95))
        {
        //Act
            if
            (
                searchIntInArray.SearchMode != null
                &&
                searchIntInArray.Ints != null
            )
                _result = SearchIntInArray.Exists(searchIntInArray.Ints,searchIntInArray.NumberToFind,searchIntInArray.SearchMode);
        //Assert
        }
    }
    /*
    <summary>
    This test asserts that in sequential search mode the search execution time is "reasonable" (arbitrarily 5 seconds)
    in the case where the integer to find is at the 95% index place in the array (position 95 in a 100 sized array)
    </summary>
    */
    [Fact(Timeout = 5000)]
    public void ExistsDichotomySearchModeFastEnoughKO()
    {
        //Arrange
        using(SearchIntInArray searchIntInArray = DryArrange(1000000,"dichotomy",95))
        {
            searchIntInArray.NumberToFind = 11;
        //Act
            if
            (
                searchIntInArray.SearchMode != null
                &&
                searchIntInArray.Ints != null
            )
                _result = SearchIntInArray.Exists(searchIntInArray.Ints,searchIntInArray.NumberToFind,searchIntInArray.SearchMode);
        //Assert
        }
    }
    /*
    <summary>
    This method doesn't repeat the arrange tested object creation and filling.
    </summary>
    <param name="arraySize">The arraySize is the number of integers in the tested item.</param>
    <param name="searchMode">searchMode is sequential or dichotomy binary search.</param>
    <param name="arrayIndexOfIntToSearch">arrayIndexOfIntToSearch is the percentage index place of searched item in the array.
    For example 50 is a searched integer in the middle of the array and 95 is at the end.
    </param>
    */
    private SearchIntInArray DryArrange(int arraySize,string searchMode, short arrayIndexOfIntToSearch)
    {
        SearchIntInArray searchIntInArray = new SearchIntInArray(arraySize,"sequential",searchMode,arrayIndexOfIntToSearch);
        if(searchIntInArray.FillMode != null)
            searchIntInArray.FillSortedArray(searchIntInArray.FillMode);
        return searchIntInArray;
    }
}