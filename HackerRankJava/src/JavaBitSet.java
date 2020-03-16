import java.io.*;
import java.util.BitSet;

public class JavaBitSet {
    private static BitSet B1;
    private static BitSet B2;

    private static void compute(BufferedReader reader) {
        try {
            String command = reader.readLine();
            initializeBitSets(command);

            command = reader.readLine();
            while (command != null) {
                System.out.println(executeBitCommand(command));
                command = reader.readLine();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static void initializeBitSets(String command) throws NumberFormatException {
        String[] bitSetSizes = command.split(" ");

        int b1Size = Integer.parseInt(bitSetSizes[0]);
        int b2Size = Integer.parseInt(bitSetSizes[1]);

        B1 = new BitSet(b1Size);
        B2 = new BitSet(b2Size);
    }

    private static String executeBitCommand(String command) {
        String[] operations = command.split(" ");
        parseCommand(operations[0], operations[1], operations[2]);
        return B1.cardinality() + " " + B2.cardinality();
    }

    private static void parseCommand(String operation, String operand1, String operand2) {
        switch (operation) {
            case "AND":
                executeAndOperation(operand1); break;
            case "OR":
                executeOrOperation(operand1); break;
            case "XOR":
                executeXorOperation(operand1); break;
            case "FLIP":
                executeFlipOperation(operand1, operand2); break;
            case "SET":
                executeSetOperation(operand1, operand2); break;
            default:
                break;
        }
    }

    private static void executeSetOperation(String operand1, String operand2) {
        if (operand1.equals("1")) {
            B1.set(Integer.parseInt(operand2));
        } else if (operand1.equals("2")) {
            B2.set(Integer.parseInt(operand2));
        }
    }

    private static void executeFlipOperation(String operand1, String operand2) {
        if (operand1.equals("1")) {
            B1.flip(Integer.parseInt(operand2));
        } else if (operand1.equals("2")) {
            B2.flip(Integer.parseInt(operand2));
        }
    }

    private static void executeXorOperation(String operand1) {
        if (operand1.equals("1")) {
            B1.xor(B2);
        } else {
            B2.xor(B1);
        }
    }

    private static void executeOrOperation(String operand1) {
        if (operand1.equals("1")) {
            B1.or(B2);
        } else {
            B2.or(B1);
        }
    }

    private static void executeAndOperation(String operand1) {
        if (operand1.equals("1")) {
            B1.and(B2);
        } else {
            B2.and(B1);
        }
    }

    public static void run() {
        String commands = "5 4\n" +
                "AND 1 2\n" +
                "SET 1 4\n" +
                "FLIP 2 2\n" +
                "OR 2 1";
        BufferedReader in = null;
        try {
            in = new BufferedReader(new FileReader(new File("./res/commands.txt")));
            compute(in);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }
}
