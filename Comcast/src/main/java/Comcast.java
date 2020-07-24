import java.util.StringTokenizer;

public class Comcast {
    public static void main(String[] args) {
        System.out.println(thirteenCharLines("Four score and seven years ago our fathers brought forth upon this continent a new nation, conceived in liberty and dedicated to the proposition that all men are created equal"));
    }

    public static String thirteenCharLines(String s) {
        if (s == null || s.length() == 0) {
            return "";
        }

        int MAX = 13;
        StringTokenizer tokenizer = new StringTokenizer(s);
        StringBuilder builder = new StringBuilder();
        int line = 0; //tracks how many characters are on the current line

        while (tokenizer.hasMoreTokens()) {
            String nextToken = tokenizer.nextToken();

            // if the current token is greater than the max then there is no way for it to fit on a line, therefore disregard it.
            if (nextToken.length() > MAX) {
                continue;
            }

            // if there is not enough space for a new word, then replace the space at the end of the line with \n
            if (line + nextToken.length() > MAX) {
                builder.replace(builder.length() - 1, builder.length(), "\n");
                line = 0;
            }

            line += nextToken.length() + 1;
            builder.append(nextToken + " ");
        }


        if(builder.length() == 0) {
            return "";
        }

        // remove space at the end of the builder
        builder.replace(builder.length() - 1, builder.length(), "");
        return builder.toString();
    }
}
