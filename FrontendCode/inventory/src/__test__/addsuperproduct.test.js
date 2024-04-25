import { render, screen, fireEvent } from '@testing-library/react';
import Addsuperproduct from '../Components/Superproduct/Addsuperproduct';
import axios from 'axios';
import { BrowserRouter } from 'react-router-dom';

jest.mock('axios', () => ({
    post: jest.fn()
}));

describe('Addsuperproduct Component', () => {
    beforeEach(() => {
        axios.post.mockClear();
    });
    test('allows the Dealer to enter their productCategory', () => {
        render(<BrowserRouter><Addsuperproduct /></BrowserRouter>);
        fireEvent.change(screen.getByTestId('productCategory-input'), { target: { value: 'chocolate' } });
        expect(screen.getByTestId('productCategory-input').value).toBe('chocolate');
    });

    test('allows the Dealer to enter their productName', () => {
        render(<BrowserRouter><Addsuperproduct /></BrowserRouter>);
        fireEvent.change(screen.getByTestId('productName-input'), { target: { value: 'Kitkat' } });
        expect(screen.getByTestId('productName-input').value).toBe('Kitkat');
    });


    test('allows the Dealer to enter their description', () => {
        render(<BrowserRouter><Addsuperproduct /></BrowserRouter>);
        fireEvent.change(screen.getByTestId('description-input'), { target: { value: 'Kit Kat is a chocolate-covered wafer bar confection created by Rowntree  of York, United Kingdom.' } });
        expect(screen.getByTestId('description-input').value).toBe('Kit Kat is a chocolate-covered wafer bar confection created by Rowntree  of York, United Kingdom.');
    });

    test('allows the Dealer to enter their buyingPrice', () => {
        render(<BrowserRouter><Addsuperproduct /></BrowserRouter>);
        fireEvent.change(screen.getByTestId('buyingPrice-input'), { target: { value: "36" } });
        expect(screen.getByTestId('buyingPrice-input').value).toBe("36");
    });

    test('allows the Dealer to enter their sellingPrice', () => {
        render(<BrowserRouter><Addsuperproduct /></BrowserRouter>);
        fireEvent.change(screen.getByTestId('sellingPrice-input'), { target: { value: "40" } });
        expect(screen.getByTestId('sellingPrice-input').value).toBe("40");
    });
    test('allows the Dealer to enter their stock', () => {
        render(<BrowserRouter><Addsuperproduct /></BrowserRouter>);
        fireEvent.change(screen.getByTestId('stock-input'), { target: { value: "1200" } });
        expect(screen.getByTestId('stock-input').value).toBe("1200");
    });
});
