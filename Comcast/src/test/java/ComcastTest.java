import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

class ComcastTest {

    @Test
    void randomTest() {
        String input = "This is a test with random words to see if the actual result is equal to the expected result";
        String expected = "This is a\n" + "test with\n" + "random words\n" + "to see if the\n" + "actual result\n" +
                "is equal to\n" + "the expected\n" + "result";
        String actual = Comcast.thirteenCharLines(input);
        assertEquals(expected, actual );
    }

    @Test
    void fourScoreTest() {
        String input = "Four score and seven years ago our fathers brought forth upon this continent a new nation, conceived in liberty and dedicated to the proposition that all men are created equal";
        String expected = "Four score\n" +
                "and seven\n" +
                "years ago our\n" +
                "fathers\n" +
                "brought\n" +
                "forth upon\n" +
                "this\n" +
                "continent a\n" +
                "new nation,\n" +
                "conceived in\n" +
                "liberty and\n" +
                "dedicated to\n" +
                "the\n" +
                "proposition\n" +
                "that all men\n" +
                "are created\n" +
                "equal";
        String actual = Comcast.thirteenCharLines(input);
        assertEquals(expected, actual);
    }

    @Test
    void emptyStringTest() {
        String input = "";
        String expected = "";
        String actual = Comcast.thirteenCharLines(input);
        assertEquals(expected, actual);
    }

    @Test
    void nullTest() {
        String input = null;
        String expected = "";
        String actual = Comcast.thirteenCharLines(input);
        assertEquals(expected, actual);
    }

    @Test
    void onlySpacesTest() {
        String input = "   ";
        String expected = "";
        String actual = Comcast.thirteenCharLines(input);
        assertEquals(expected, actual);
    }

    @Test
    void multipleSpacesAndWordsTest() {
        String input = "This     is     a           test";
        String expected = "This is a\n" + "test";
        String actual = Comcast.thirteenCharLines(input);
        assertEquals(expected, actual);
    }

    @Test
    void thirteenCharacterStringTest() {
        String input = "The man was hyperbolizing the size of the fish";
        String expected = "The man was\n" + "hyperbolizing\n" + "the size of\n" + "the fish";
        String actual = Comcast.thirteenCharLines(input);
        assertEquals(expected, actual);
    }

    @Test
    void fourteenCharacterStringTest() {
        String input = "He needed certifications for the job";
        String expected = "He needed for\n" + "the job";
        String actual = Comcast.thirteenCharLines(input);
        assertEquals(expected, actual);
    }

    @Test
    void onlyFourteenCharacterStringTest() {
        String input = "certifications";
        String expected = "";
        String actual = Comcast.thirteenCharLines(input);
        assertEquals(expected, actual);
    }

    @Test
    void spacesAndFourteenCharacterStringTest() {
        String input = "       certifications       ";
        String expected = "";
        String actual = Comcast.thirteenCharLines(input);
        assertEquals(expected, actual);
    }

    @Test
    void singleLetterWordsTest() {
        String input = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
        String expected = "a b c d e f g\n" + "h i j k l m n\n" + "o p q r s t u\n" + "v w x y z";
        String actual = Comcast.thirteenCharLines(input);
        assertEquals(expected, actual);
    }
}